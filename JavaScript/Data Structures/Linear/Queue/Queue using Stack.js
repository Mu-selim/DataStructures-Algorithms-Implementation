class Queue {
    constructor() {
        this.stack1 = [];
        this.stack2 = [];
        this.count = 0;
    }

    IsEmpty() {
        return this.count === 0;
    }

    Enqueue(value) {
        while(this.stack1.length > 0) {
            this.stack2.push(this.stack1.pop());
        }

        this.stack1.push(value);

        while(this.stack2.length > 0) {
            this.stack1.push(this.stack2.pop());
        }
        this.count += 1;
    }

    Dequeue() {
        if(this.IsEmpty()) {
            console.log('Queue is EMPTY');
            return null;
        } else {
            let temp = this.stack1.pop();
            this.count -= 1;
            return temp;
        }
    }

    Clear() {
        this.stack1 = [];
        this.stack2 = [];
        this.count = 0;
    }

    displayQueue() {
        console.log(this.stack1);
    }
}

let queue = new Queue();
queue.Enqueue(10);
queue.Enqueue(3);
queue.Enqueue(-5);
queue.Enqueue(4);
queue.Enqueue(-9);
queue.displayQueue();
queue.Dequeue();
queue.Dequeue()
console.log("number of Queue items: " + queue.count);
queue.displayQueue();
queue.Clear();
queue.displayQueue();