class Node():
	def __init__(self, data, link):
		self.data = data
		self.link = link

class Stack():

	def __init__(self):
		self.head = None

	def push(self, data):
		self.head = Node(data, self.head)

	def pop(self):
		if(self.head == None):
			print("Pop from empty stack.\n")
			return

		data = self.head.data
		self.head = self.head.link

		return data

	def peek(self):
		if(self.head == None):
			print("Peek from empty stack.\n")
			return

		return self.head.data

	def isEmpty(self):
		return self.head == None

stack = Stack()
for i in range(0, 9):
	stack.push(i)

for i in range(0, 5):
	print(stack.pop())

