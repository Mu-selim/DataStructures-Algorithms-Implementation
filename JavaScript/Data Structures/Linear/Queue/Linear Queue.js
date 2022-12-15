class LinearQueue {
    constructor() {
        this.queue = [];
        this.front = -1;
        this.rear = -1;
    }

    IsEmpty() {
        return this.rear < 0;
    }

    Enqueue(value) {
        this.queue.push(value);
        this.rear += 1;
    }

    Dequeue() {
        if(this.IsEmpty()) {
            console.log('Queue is Empty');
        } else {
            let temp = this.queue[0];
            for(let i = 0; i < this.rear; i++) {
                this.queue[i] = this.queue[i+1];
            }
            this.rear -= 1;
            this.queue.pop();
            return temp;
        }
    }

    GetFront() {
        if(this.IsEmpty()) {
            return -1;
        } else {
            return this.front+1;
        }
    }

    GetRear() {
        if(this.IsEmpty()) {
            return -1;
        } else {
            return this.rear;
        }
    }

    Clear() {
        this.queue = [];
        this.front = -1;
        this.rear = -1;
    }

    Count() {
        return this.rear+1;
    }

    DisplayQueue() {
        console.log(this.queue);
    }
}


// Testing.
let queue = new LinearQueue();
console.log(queue.Count());
queue.Enqueue(10);
queue.Enqueue(14);
queue.Enqueue(36);
queue.Enqueue(-10);
console.log(queue.Count());
queue.DisplayQueue();
console.log(queue.Dequeue());
console.log(queue.Dequeue());
console.log(queue.GetFront());
console.log(queue.GetRear());
console.log(queue.Count());
queue.Enqueue(40);
console.log(queue.Count());
queue.DisplayQueue();
console.log(queue.GetFront());
console.log(queue.GetRear());
queue.Clear();
console.log(queue.Count());