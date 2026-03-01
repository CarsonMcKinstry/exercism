//
// This is only a SKELETON file for the 'Secret Handshake' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

const actions = new Map([
  [1, 'wink'],
  [2, 'double blink'],
  [4, 'close your eyes'],
  [8, 'jump']
]);

export const secretHandshake = handShake => {

  if (typeof handShake !== 'number') {
    throw new Error("Handshake must be a number");
  }
  const handShakeString = handShake.toString(2);
  const parsedHandshake = parseInt(handShakeString, 2);
  const instructions = [];
  for (let i = 0; i < handShakeString.length; i++) {
    const action = parsedHandshake & ('1' << i);
    if (action === 16) {
      instructions.reverse();
    } else if (actions.has(action) ) {
      instructions.push(actions.get(action));
    }
  }
  return instructions;
};
