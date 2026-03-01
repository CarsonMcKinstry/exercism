export function reverse(input: string): string {
  const len = input.length - 1;

  let output = [...input];

  for (let i = 0; i < Math.floor(len / 2); i++) {
    const temp = output[i];
    output[i] = output[len - i];
    output[len - i] = temp;
  }

  return output.join('');
}
