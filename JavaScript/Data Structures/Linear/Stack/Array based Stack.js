class Stack {
    constructor() {
        this.stack = [];
        this.top = -1;
    }

    isFull() {
        return this.top >= 1000? true: false;
    }

    isEmpty() {
        return this.top < 0? true: false;
    }

    push(value) {
        if(!this.isFull()) {
            this.top += 1;
            this.stack.push(value);
        } else {
            console.log("Stack is FULL!");
        }
    }

    pop() {
        if(!this.isEmpty()) {
            this.top -= 1;
            return this.stack.pop();
        } else {
            return "Stack is EMPTY!";
        }
    }

    peek() {
        if(!this.isEmpty()) {
            return this.stack[this.top];
        } else {
            return "Stack is EMPTY!";
        }
    }

    count() {
        return (this.top + 1);
    }

    displayStack() {
        if(!this.isEmpty()) {
            console.log(this.stack);
        } else {
            console.log("Stack is EMPTY!");
        }
    }
}

let stack = new Stack();
console.log(stack.isEmpty());
console.log(stack.pop());

stack.push(10);
stack.push(20);
stack.push(-45);
stack.push(20);
stack.push(12);
stack.displayStack();
console.log(stack.count());

console.log(stack.peek());
stack.pop();
console.log(stack.peek());
console.log(stack.count());
stack.displayStack();