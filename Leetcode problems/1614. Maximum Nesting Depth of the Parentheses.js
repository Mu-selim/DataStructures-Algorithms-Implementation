/**
 * @param {string} s
 * @return {number}
 */
var maxDepth = function(s) {
    let stack = [], max = 0, len = s.length, count = 0;
    for(let i = 0; i < len; i++) {
        if(s[i] === '(') {
            stack.push('(');
            count += 1;
        } else if(s[i] === ')' && stack.length > 0) {
            stack.pop();
            count -= 1;
        }
        max = Math.max(max, count);
    }
    return max;
};

console.log(maxDepth("(1+(2*3)+((8)/4))+1"));
console.log(maxDepth("(1)+((2))+(((3)))"));