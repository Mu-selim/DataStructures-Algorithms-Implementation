/**
 * @param {string} s
 * @return {boolean}
 */
var arePair = function(c1, c2) {
    if(c1 == '(' && c2 == ')') {
        return true;
    } else if(c1 == '{' && c2 == '}') {
        return true;
    } else if(c1 == '[' && c2 == ']') {
        return true;
    } 
    return false;
}

var isValid = function(s) {
    let n = s.length, stack = [];
    for(let i = 0; i < n; i++) {
        let c = s[i];
        if(c == '(' || c == '{' || c == '[') {
            stack.push(c);
        } else if(!arePair(stack.pop(), c)) {
            return false;
        }
    }
    return stack.length == 0;
};

console.log(isValid(s = "()"));
console.log(isValid(s = "()[]{}"));
console.log(isValid(s = "(]"));
console.log(isValid(s = "["));