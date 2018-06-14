#include <stdio.h>
#include <stdlib.h>

/* Implement a Stack using a Linked-List 
   1. Create the initial linked list by creating a Node that points to NULL, this will be the top of the list
   2. To push, create a new node and point this node to the top, then create the new "top" as this node
   3. To pop, create a temporary node to hold the current "top" node. Then change the "top" to the node that the current "top"
      is pointing to. Then free the memory of the tempory node, which should be holding the old "top"
      */

struct Node{
	int data;
	struct Node* next;
};

struct Node* top = NULL;

void push(int x){
	struct Node* temp = (struct Node*)malloc(sizeof(struct Node*));
	temp -> data = x;
	temp -> next = top;
	top = temp;
}

void pop(){
	struct Node* temp;
	if (top == NULL) return;
	temp = top;
	top = top -> next;
	free(temp);
}

void print_stack(){
	struct Node* temp = top;
	while(temp!=NULL){
		printf("%d ", temp -> data);
		temp = temp -> next;
	}
	printf("\n");
}

int Top(){
	if(top != NULL){
		return (top -> data);
	}
}

int main(int argc, char** argv){
	push(5);
	print_stack();
	push(6);
	print_stack();
	pop();
	print_stack();
	push(9);
	push(11);
	printf("%d\n", Top());
	
}