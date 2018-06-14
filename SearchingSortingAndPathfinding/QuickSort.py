def QuickSort(array, left, right):
	index = partition(array, left,right)
	if(left < index - 1):
		QuickSort(array, left, index - 1)

	if (index < right):
		QuickSort(array, index, right)

def partition(array, left, right):
	pivot = array[left + (right-left)//2]
	while(left <= right):

		while(array[left] < pivot):
			left += 1

		while(array[right] > pivot):
			right -= 1

		if(left <= right):
			array[right], array[left] = array[left], array[right]
			left += 1
			right -= 1

	return left

array  = [3,4,6,7,1,9,12,36,43,11]
QuickSort(array, 0, len(array) - 1)
print(array)