class Node():
	def __init__(self, data, link):
		self.data = data
		self.link = link

	def __repr__(self):
		return "Node <{}>".format(self.data)

class Queue():

	def __init__(self):
		self.front, self.rear = None, None

	def Enqueue(self, data):
		if(self.front == None and self.rear == None):
			self.front = self.rear = Node(data, None)
			return

		self.rear.link = Node(data, None)
		self.rear = self.rear.link

	def Dequeue(self):
		if(self.front == None):
			print("Dequeue from empty queue.\n")
			return

		data = self.front.data
		self.front = self.front.link

		return data


	def isEmpty(self):
		return (self.front == None and self.rear == None)

queue = Queue()
for i in range(0, 9):
	queue.Enqueue(i)

for i in range(0, 5):
	print(queue.Dequeue())