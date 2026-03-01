//
// This is only a SKELETON file for the 'Linked List' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

class Node {
    constructor(value, index) {
        this.value = value;
        this.index = index;
    }

    increaseIndex(i) {
        this.index = this.index + i;
    }

    decreaseIndex(i) {
        this.index = this.index - i;
    }

    get next() {
        return index + 1;
    }

    get previous() {
        return index - 1;
    }
}

export class LinkedList {
    constructor() {
        this.nodes = [];
    }
    push(v) {
        const node = new Node(v, this.nodes.length);
        this.nodes.push(node);
        return node;
        // throw new Error("Remove this statement and implement this function");
    }

    pop() {
        const returning = this.nodes.pop();

        return returning.value;
        // throw new Error("Remove this statement and implement this function");
    }

    shift() {
        const returning = this.nodes.shift();

        this.nodes.forEach(node => node.decreaseIndex(1));

        return returning.value;
    }

    unshift(v) {
        const node = new Node(v, 0);

        this.nodes.forEach(node => node.increaseIndex(1));

        this.nodes.unshift(node);

        return node;
    }

    delete(v) {
        const index = this.nodes.findIndex(n => n.value === v);

        if (index < 0) return;

        for (let i = index + 1; i < this.nodes.length; i++) {
            this.nodes[i].decreaseIndex(1);
        }

        this.nodes.splice(index, 1);
    }

    count() {
        return this.nodes.length;
    }
}
