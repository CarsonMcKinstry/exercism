class SyntaxError extends Error {
    constructor() {
        super('Syntax error');
    }
}

class UknownOperationError extends Error {
    constructor() {
        super('Unknown operation');
    }
}

const isNumber = (input: any): input is number => {
    return !isNaN(Number(input));
}

const isValidWord = (token: string) => {
    return [
        'what',
        'is',
        'by',
        'to',
        'the',
        'power'
    ].includes(`${token}`.toLowerCase());
}

const isOperator = (token: string) => {
    return [
        'plus',
        'minus',
        'multiplied',
        'divided',
        'raised'
    ].includes(`${token}`.toLowerCase());
}

const evaluate = (operation: string, left: number, right: number) => {
    switch (operation) {
        case 'plus':
            return left + right;
        case 'minus':
            return left - right;
        case 'multiplied':
            return left * right;
        case 'divided':
            return left / right;
        case 'raised':
            return left ** right;
    }

    throw new Error('Syntax error');
}

const tokenize = (question: string) => {

    return question.replace(/\?/g, '').split(' ')
        .reduce<any[]>((memo, token) => {

            if (isOperator(token)) {
                memo.push(token);
            } else if (isNumber(token)) {
                memo.push(Number(token));
            } else if (isNumber(token[0])) {
                memo.push(Number(token.slice(0, -2)));
            } else if (!isValidWord(token)) {
                throw new UknownOperationError();
            }

            return memo;
        }, [])
}

export const answer = (question: string) => {
    const tokens = tokenize(question);
    const stack: (string | number)[] = [];

    if (tokens.length === 1 && isNumber(tokens[0])) {
        return tokens[0];
    }

    if (tokens.length < 3) throw new SyntaxError();
    for (let i = 0; i < tokens.length; i++) {
        if (tokens[i - 1] && isOperator(tokens[i - 1] as string)) {
            const op = stack.pop();
            const x = stack.pop();
            const y = tokens[i];

            console.log({
                op,
                x,
                y
            });

            if (x == null || y == null) {
                throw new SyntaxError();
            }

            stack.push(evaluate(op as string, x as number, y as number));
        } else {
            stack.push(tokens[i]);
        }
    }

    if (stack.length > 1) {
        throw new SyntaxError();
    }

    return stack[0];
}