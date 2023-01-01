/**
 * @param {number} n
 * @return {boolean}
 */
var canWinNim = function(n) {
    return n%4? true: false;
};

console.log(canWinNim(n = 4));
console.log(canWinNim(n = 1));
console.log(canWinNim(n = 2));