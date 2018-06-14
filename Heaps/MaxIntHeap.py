class MaxIntHeap():

	def __init__(self, size = 0):
		self.items = []
		self.size = size

	def peek(self):
		if self.size == 0:
			print("Peek from empty Heap.\n")
			return

		return self.items[0]

	def poll(self):
		if self.size == 0:
			print("Peek from empty Heap.\n")
			return

		#get the top element in  heap
		temp = self.items[0]

		#replace it with bottom element and heapify down
		self.items[0] = self.items[self.size - 1]
		self.size -= 1

		MaxIntHeap.heapifyDown(self)
		return temp

	def add(self, data):
		self.items.append(data)
		self.size += 1

		MaxIntHeap.heapifyUp(self)

	def heapifyDown(self):
		index = 0

		#get max of both left and right child
		while(MaxIntHeap.hasLeftChild(self, index)):
			largerIndex = MaxIntHeap.getLeftChildIndex(self, index)
			if(MaxIntHeap.hasRightChild(self, index) and MaxIntHeap.right(self, index) > self.items[largerIndex]):
				largerIndex = MaxIntHeap.getRightChildIndex(self, index)

			if(self.items[index] > self.items[largerIndex]):
				break
			else:
				MaxIntHeap.swap(self, index, largerIndex)

			index = largerIndex

	def heapifyUp(self):
		index = self.size - 1

		while(MaxIntHeap.hasParent(self, index) and MaxIntHeap.parent(self, index) < self.items[index]):
			MaxIntHeap.swap(self, index, MaxIntHeap.getParentIndex(self, index))
			index = MaxIntHeap.getParentIndex(self, index)

	#helper methods
	def swap(self, firstIndex, secondIndex):
		self.items[secondIndex], self.items[firstIndex] = self.items[firstIndex], self.items[secondIndex]

	def hasLeftChild(self, index):
		return MaxIntHeap.getLeftChildIndex(self, index) < self.size

	def hasRightChild(self, index):
		return MaxIntHeap.getRightChildIndex(self, index) < self.size

	def hasParent(self, index):
		return MaxIntHeap.getParentIndex(self, index) >= 0

	def getLeftChildIndex(self, index):
		return 2*index + 1

	def getRightChildIndex(self, index):
		return 2*index + 2

	def getParentIndex(self, index):
		return (index - 1)//2

	def left(self, index):
		return self.items[MaxIntHeap.getLeftChildIndex(self, index)]

	def right(self, index):
		return self.items[MaxIntHeap.getRightChildIndex(self, index)]

	def parent(self, index):
		return self.items[MaxIntHeap.getParentIndex(self, index)]

maxHeap = MaxIntHeap()
maxHeap.add(5)
maxHeap.add(6)

maxHeap.poll()
print(maxHeap.peek())