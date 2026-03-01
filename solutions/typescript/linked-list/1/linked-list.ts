export class Node<T> {
  value: T;
  next: Node<T> | null = null;

  constructor(value: T) {
    this.value = value;
  }
}

export default class SinglyLinkedList<T> {
  head: Node<T> | null = null;
  tail: Node<T> | null = null;
  length = 0;

  push(value: T): void {
    const nextNode = new Node(value);

    if (!this.head) {
      this.head = nextNode;
      this.tail = this.head;
    } else {
      this.tail!.next = nextNode;
      this.tail = nextNode;
    }

    this.length++;
  }

  pop(): T | null {
    if (!this.head) return null;
    let curr = this.head;
    let newTail = curr;

    while (curr.next) {
      newTail = curr;
      curr = curr.next;
    }
    this.tail = newTail;
    this.tail.next = null;
    this.length--;
    if (this.length === 0) {
      this.head = null;
      this.tail = null;
    }

    return curr.value;
  }

  shift(): T {
    if (this.head === null) {
      throw new Error("Attempted to shift on a list of length 0");
    }

    const oldHead = this.head;
    this.head = oldHead.next;
    this.length--;

    if (this.length === 0) {
      this.tail = null;
    }

    return oldHead.value;
  }

  unshift(value: T): void {
    const nextNode = new Node(value);

    if (this.head === null) {
      this.head = nextNode;
      this.tail = nextNode;
    } else {
      nextNode.next = this.head;
      this.head = nextNode;
    }

    this.length++;
  }

  delete(valueToDelete: T): void {
    if (this.head === null) {
      throw new Error("Attempted to delete on a list of length 0");
    }

    if (this.length === 1 && this.head.value === valueToDelete) {
      this.head = null;
      this.tail = null;
      this.length--;
    } else {
      let curr = this.head;
      let newTail = curr.next;

      while (curr.next) {
        if (newTail?.value === valueToDelete) {
          curr.next = newTail.next;
          this.length--;
          break;
        }

        newTail = curr;
        curr = curr.next;
      }
    }
  }

  count(): number {
    return this.length;
  }
}
