const isPalindrome = (expression) => {
    let len = expression.length, i = 0, stack = [];
    while(i < Math.floor(len/2)) {
        stack.push(expression[i++]);
    }

    // checks if expression length is even.
    i = len % 2 === 0? i: i+1;

    while(i < len) {
        if(stack.pop() != expression[i++]) {
            return false;
        }
    }
    return true;
}

console.log(isPalindrome("MbabM"));
console.log(isPalindrome("MaaM"));
console.log(isPalindrome('Muhamamad'));
console.log(isPalindrome('madam'));
console.log(isPalindrome('ababab'));
console.log(isPalindrome('aaaaa'));
console.log(isPalindrome('abababb'));
console.log(isPalindrome('ab'));
console.log(isPalindrome('a'));
console.log(isPalindrome('abababa'));