#include <stdio.h>
#include <stdlib.h>

struct Node{
	int data;
	struct Node* next;
};

struct Node* top = NULL;
struct Node* rear = NULL;

void enqueue(int x){
	struct Node* temp = (struct Node*)malloc(sizeof(struct Node));
	temp -> data = x;
	temp -> next = NULL;
	if(top == NULL && rear == NULL){
		top = rear = temp;
		return;
	}
	rear -> next = temp;
	rear = temp;
}

void dequeue(){
	struct Node* temp = top;
	if(top == NULL) return;
	if(top == rear){
		top = rear = NULL;
		return;
	} else{
		top = top -> next;
	}
	free (temp);
}

void print_queue(){
	struct Node* temp = top;
	while(temp!=NULL){
		printf("%d ", temp -> data);
		temp = temp -> next;
	}
	printf("\n");
}

int main(int argc, char** argv){
	enqueue(2);
	print_queue();
}