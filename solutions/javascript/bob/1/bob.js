/* eslint-disable no-unused-vars */
//
// This is only a SKELETON file for the 'Bob' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const hey = message => {
    const trimmed = message.trim();

    const silence = message.replace(/[\s\r\t\n]/g, "").trim().length === 0;

    if (silence) return "Fine. Be that way!";

    const questioning = trimmed.endsWith("?");

    const yelling =
        trimmed.toUpperCase() === message &&
        !Number(trimmed.replace(/\W+/g, "")) &&
        trimmed.replace(/[\W]/g, "").trim().length > 0;

    if (yelling && questioning) return "Calm down, I know what I'm doing!";
    if (yelling) return "Whoa, chill out!";
    if (questioning) return "Sure.";

    return "Whatever.";
};
