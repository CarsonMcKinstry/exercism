type Nullable<T> = T | null;

export class Node<T> {
    next: Nullable<Node<T>> = null;

    constructor(public value: T) {}
}

export default class SinglyLinkedList<T> {
    head: Nullable<Node<T>> = null;
    tail: Nullable<Node<T>> = null;
    length = 0;

    push(value: T) {
        const node = new Node(value);

        if (!this.head || !this.tail) {
            this.head = node;
            this.tail = node;
        } else {
            this.tail.next = node;
            this.tail = node;
        }

        this.length++;
    }

    pop() {
        if (!this.head || !this.tail) return;

        for (const [prev, curr] of this.iterAround()) {
            if (curr) {
                if (curr.next === null) {
                    if (prev) {
                        prev!.next = null;
                    }

                    this.tail = prev;
                    this.length--;
                    return curr.value;
                }
            }
        }
        return;
    }

    shift() {
        if (!this.head || !this.tail) return;

        const shifted = this.head;

        this.head = shifted.next;

        this.length--;

        if (!this.length) {
            this.tail = null;
            this.head = null;
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
            this.head = node;
        }

        this.length++;
    }

    count() {
        return this.length;
    }

    delete(toDelete: T) {
        if (!this.head || !this.tail) return;

        for (const [prev, curr] of this.iterAround()) {
            if (curr) {
                if (curr.value === toDelete) {
                    if (prev) {
                        prev.next = curr.next;
                    }
                    this.length--;
                    return curr.value;
                }
            }
        }
    }

    *iterAround() {
        let prev = null;
        let curr = this.head;

        while (curr) {
            yield [prev, curr];
            prev = curr;
            curr = curr.next;
        }
    }
}
