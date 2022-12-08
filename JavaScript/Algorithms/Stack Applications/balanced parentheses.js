
let arePair = (c1, c2) => {
    if(c1 === '(' && c2 === ')')
        return true;
    else if(c1 === '[' && c2 === ']')
        return true;
    else if(c1 === '{' && c2 === '}')
        return true;
    else
        return false;
}

let isBalanced = (s) => {
    let stack = [];
    for(let i = 0; i < s.length; i++) {
        if(s[i] === '(' || s[i] === '[' || s[i] === '{') {
            stack.push(s[i]);
            continue;
        }

        if(s[i] === ')' || s[i] === ']' || s[i] === '}') {
            if(stack.length === 0 || !arePair(stack.pop(), s[i])) {
                return false;
            }
        }
    }
    return true;
}

console.log(isBalanced('{}'));
console.log(isBalanced('{()}'));
console.log(isBalanced('{)}'));
console.log(isBalanced('{(())()[()]}'));
console.log(isBalanced('{(())()[()])}'));
console.log(isBalanced('{(())()[(])}'));
console.log(isBalanced('{(())()[([{}])]}'));
console.log(isBalanced('}{(())()[()]}'));
