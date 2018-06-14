class Node(object):

	def __init__(self, data = None, next = None):
		self.data = data
		self.next = next

	def get_data(self):
		return self.data

	def get_next(self):
		return self.next

	def set_next(self, new_next):
		self.next = new_next
		
class LinkedList(object):

	def __init__(self, top = None):
		self.top = top

	def insert(self, data):
		new_node = Node(data)
		new_node.set_next(self.top)
		self.top = new_node

	def size(self):
		current_node = self.top
		count = 0
		while(current_node):
			count += 1
			current_node = current_node.get_next()
		return count

	def search(self, data):
		current_node = self.top
		found = False
		while(current_node and found == False):
			if(data == current_node.get_data()):
				found = True
			else:
				current_node = current_node.get_next()
		if current_node is None:
			raise ValueError("Data not in list")
		return current_node

	def delete(self, data):
		current_node = self.top
		found = False
		previous = None
		while(current_node and found == False):
			if(data == current_node.get_data()):
				found = True
			else:
				previous = current_node
				current_node = current_node.get_next()
		if current_node == None:
			raise ValueError("Data not in list")
		if previous == None:
			previous = current_node.get_next()
		else:
			previous.set_next(current_node.get_next())

			


