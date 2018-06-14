#Set up node class
	
class Node():

	def __init__(self, data: int, left_Child: "Node" = None, right_Child: "Node" = None):
		self.data = data
		self.left_Child = left_Child
		self.right_Child = right_Child

class BST():

	def __init__(self):
		self.root = None
		self.size = 0

	def __set_root(self, data):
		#current issue with this is that if we already have a binary search tree made, and we want to change the root node using set_root
		#then this will set the root but will also get rid of the rest of the tree that was already made, it will not be preserved
		#For this reason, we will set the "set_root" method as a private method
		self.root = Node(data)

	def get_size(self):
		return self.size

	def insert(self, data):
		if(self.root == None):
			self.__set_root(data)

		else:
			self.insert_node(self.root, data)

		#update the size
		self.size += 1

	def insert_node(self, current_node, data):
		#Check for duplicate
		if(self.find(data)):
			print("That data already exists in the tree.")
			return

		#check to see if the data being inserted is less than the current Nodes data
		if(data <= current_node.data):
			#check to see if a left child already exists, if it does then start over but from the left child
			if(current_node.left_Child):
				self.insert_node(current_node.left_Child, data)
			else:
				current_node.left_Child = Node(data)

		#Check right child		
		elif(data > current_node.data):
			if(current_node.right_Child):
				self.insert_node(current_node.right_Child, data)
			else:
				current_node.right_Child = Node(data)


	def find(self, data):
		return self.find_Node(self.root, data)

	def find_Node(self, current_node, data):

		#Did not find the data
		if(current_node == None):
			return False

		#found the data
		if(data == current_node.data):
			return True
		elif(data <= current_node.data):
			return self.find_Node(current_node.left_Child, data)
		else:
			return self.find_Node(current_node.right_Child, data)






