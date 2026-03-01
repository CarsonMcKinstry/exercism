type Nullable<T> = T | null;

export class Node<T> {
    next: Nullable<Node<T>> = null;
    prev: Nullable<Node<T>> = null;

    constructor(public value: T) {}
}

export class LinkedList<T> {
    head: Nullable<Node<T>> = null;
    tail: Nullable<Node<T>> = null;
    length = 0;

    push(value: T) {
        const node = new Node(value);

        if (!this.head || !this.tail) {
            this.head = node;
            this.tail = node;
        } else {
            node.prev = this.tail;
            this.tail.next = node;
            this.tail = node;
        }

        this.length++;
    }

    pop() {
        if (!this.head || !this.tail) return;

        const popped = this.tail;

        this.tail = popped.prev;
        popped.next = null;

        this.length--;

        if (this.length === 0) {
            this.head = null;
            this.tail = null;
        }

        return popped.value;
    }

    shift() {
        if (!this.head || !this.tail) return;

        const shifted = this.head;

        this.head = shifted.next;

        if (this.head) {
            this.head.prev = null;
        }

        this.length--;

        if (this.length === 0) {
            this.head = null;
            this.tail = null;
        }
        return shifted.value;
    }

    unshift(value: T) {
        const node = new Node(value);

        if (!this.head || !this.tail) {
            this.head = node;
            this.tail = node;
        } else {
            node.next = this.head;
            this.head.prev = node;
            this.head = node;
        }

        this.length++;
    }

    count() {
        return this.length;
    }

    delete(toDelete: T) {
        if (this.head?.value === toDelete) {
            return this.shift();
        }

        if (this.tail?.value === toDelete) {
            return this.pop();
        }

        for (const node of this.iter()) {
            if (node.value === toDelete) {
                node.prev!.next = node.next;
                this.length--;

                return node.value;
            }
        }

        return;
    }

    *iter() {
        let curr = this.head;

        while (curr) {
            yield curr;
            curr = curr.next;
        }
    }
}
