//
// This is only a SKELETON file for the 'etl' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const transform = (old) => {
  return Object.entries(old).reduce((scores, [score, keys]) => {
    for(const key of keys) {
      scores[key.toLowerCase()] = Number(score);
    }

    return scores;
  }, {});
};
