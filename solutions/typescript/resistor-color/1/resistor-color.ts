export const COLORS = [
  "black",
  "brown",
  "red",
  "orange",
  "yellow",
  "green",
  "blue",
  "violet",
  "grey",
  "white",
];

export const colorCode = (color: string) => {
  const id = COLORS.findIndex((c) => c === color);

  if (id > -1) {
    return id;
  }
  throw new Error("Delete this line and implement this function");
};
