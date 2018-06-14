class MinIntHeap():

	def __init__(self, size = 0):
		self.items = []
		self.size = size

	def peek(self):
		if self.size == 0:
			print("Heap is empty")
			return

		return self.items[0]

	def poll(self):
		if self.size == 0:
			print("Heap is empty")
			return

		item = self.items[0]
		self.items[0] = self.items[self.size - 1]
		self.size -= 1

		MinIntHeap.heapifyDown(self)
		return item

	def add(self, item):
		self.items.append(item)
		self.size += 1

		MinIntHeap.heapifyUp(self)

	def heapifyUp(self):
		index = self.size - 1
		while(MinIntHeap.hasParent(self,index) and MinIntHeap.parent(self, index) > self.items[index]):
			#things are out of order

			#swap with parent and walk upwards
			MinIntHeap.swap(self, MinIntHeap.getParentIndex(index), index)
			index = MinIntHeap.getParentIndex(index)


	def heapifyDown(self):
		index = 0
		while(MinIntHeap.hasLeftChild(self, index)):
			smallerIndex = MinIntHeap.getLeftChildIndex(index)
			if(MinIntHeap.hasRightChild(self, index) and MinIntHeap.rightChild(self, index) < MinIntHeap.leftChild(self, index)):
				smallerIndex = MinIntHeap.getRightChildIndex(index)

			if(self.items[index] < self.items[smallerIndex]):
				break
			else:
				MinIntHeap.swap(self, index, smallerIndex)

			index = smallerIndex


	#Helper Methods
	def swap(self, indexOne, indexTwo):
		temp = self.items[indexOne]
		self.items[indexOne], self.items[indexTwo] = self.items[indexTwo], temp

	def getLeftChildIndex(parentIndex): 
		return 2*parentIndex + 1

	def getRightChildIndex(parentIndex):
		return 2*parentIndex + 2

	def getParentIndex(childIndex):
		return (childIndex - 1)//2

	def hasLeftChild(self, parentIndex):
		return MinIntHeap.getLeftChildIndex(parentIndex) < self.size

	def hasRightChild(self, parentIndex):
		return MinIntHeap.getRightChildIndex(parentIndex) < self.size

	def hasParent(self, index):
		return MinIntHeap.getParentIndex(index) >= 0

	def leftChild(self, index):
		return self.items[MinIntHeap.getLeftChildIndex(index)]

	def rightChild(self, index):
		return self.items[MinIntHeap.getRightChildIndex(index)]

	def parent(self, index):
		return self.items[MinIntHeap.getParentIndex(index)]


minheap = MinIntHeap()
minheap.add(5)
minheap.add(6)
minheap.add(3)

print(minheap.poll())
