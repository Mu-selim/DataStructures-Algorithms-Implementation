class CircularQueue {
    constructor(value) {
        this.queue = [];
        this.front = 0;
        this.rear = value-1;
        this.capacity = value;
        this.count = 0; 
    }

    IsFull() {
        return this.count === this.capacity;
    }

    IsEmpty() {
        return this.count === 0;
    }

    Enqueue(value) {
        if(!this.IsFull()) {
            this.rear = (this.rear+1) % this.capacity;
            this.queue[this.rear] = value;
            this.count += 1;
        } else {
            console.log('Queue is Full');
        }
    }

    Dequeue() {
        if(!this.IsEmpty()) {
            let temp = this.queue[this.front];
            this.queue[this.front] = 0;
            this.front = (this.front+1) % this.capacity;
            this.count -= 1;
            return temp;
        } else {
            console.log('Queue is Empty');
        }
    }

    GetFront() {
        if(!this.IsEmpty()) {
            return this.front;
        } else {
            return -1;
        }
    }

    GetRear() {
        if(!this.IsEmpty()) {
            return this.rear;
        } else {
            return -1;
        }
    }

    Clear() {
        this.queue = [];
        this.front = 0;
        this.rear = this.capacity-1;
        this.count = 0; 
    }

    Count() {
        return this.count;
    }

    IncreseCapacity(value) {
        this.capacity += value;
    }

    DisplayQueue() {
        let res = "", temp = 0;
        for(let i = this.front; i !== this.rear; i = (i+1)%this.capacity) {
            res += `${this.queue[i]} `;
            if(temp > 10) {
                break;
            }
            temp += 1;
        }
        res += this.queue[this.rear];
        console.log(res);
    }
}

// Testing.
let queue = new CircularQueue(5);
console.log(queue.Count());
queue.Enqueue(10);
queue.Enqueue(14);
queue.Enqueue(36);
queue.Enqueue(-10);
queue.Enqueue(40);
console.log(queue.Count());
queue.DisplayQueue();
console.log(queue.Dequeue());
console.log(queue.Dequeue());
console.log(queue.GetFront());
console.log(queue.GetRear());
console.log(queue.Count());
queue.Enqueue(500);
console.log(queue.Count());
queue.DisplayQueue();
console.log(queue.GetFront());
console.log(queue.GetRear());
console.log(queue.Dequeue());
console.log(queue.Count());
queue.Enqueue(100);
queue.DisplayQueue();
console.log(queue.Count());
queue.Clear();
console.log(queue.Count());