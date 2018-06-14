from Queue import Queue

class Node():
	def __init__(self, data: int, link: "Node" = None):
		self.data = data
		self.link = link
		self.visited = False
		self.adjecentList = []

	def __repr__(self):
		return "Node <{}>".format(self.data)

def DFS(root):
	if(root == None):
		return

	print(root)
	root.visited = True
	for node in root.adjecentList:
		if(node.visited == False):
			DFS(node)


def BFS(root):
	queue = Queue()
	if(root == None):
		return

	root.visited = True
	queue.Enqueue(root) #add to the end of the queue

	while(queue.isEmpty == False):
		r = queue.Dequeue()
		print(r)
		for node in r.adjecentList:
			if(node.visited == False):
				node.visited = True
				queue.Enqueue(node)