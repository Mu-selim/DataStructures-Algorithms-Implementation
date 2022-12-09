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
    return stack.length === 0;
}

let precedence = (sign) => {
    switch(sign) {
        case '(':
        case ')':
            return 1;
        case '+':
        case '-':
            return 2;
        case '*':
        case '/':
            return 3;
        case '^':
            return 4;
    }
    return -1;
}

let isOperator = (sign) => {
    return ['+', '-', '*', '/', '^'].includes(sign);
}

let postfixConvert = (expression) => {
    let stack = [], len = expression.length, res = "";

    for(let i = 0; i < len; i++) {

        let numberFlag = false;
        while(i < len && !isNaN(expression[i])) {
            res += expression[i++];
            numberFlag = true;
        }

        if(numberFlag) {
            res += ' ';
        }

        if(expression[i] === ')') {
            while(stack[stack.length-1] !== '(') {
                res += stack.pop() + ' ';
            }
            stack.pop();
        } else if(expression[i] === '(') {
            stack.push(expression[i]);
        } else {
            while(stack.length > 0 && precedence(expression[i]) <= precedence(stack[stack.length-1])) {
                res += stack.pop() + ' ';
            }
            stack.push(expression[i]);
        }
    }

    while(stack.length > 0) {
        res += stack.pop() + ' ';
    }
    res = res.split(' ');
    return res.filter(item => item !== '');
}

let calculate = (n1, n2, operation) => {
    n1 = parseFloat(n1), n2 = parseFloat(n2);
    switch(operation) {
        case '+':
            return n1+n2;
        case '-':
            return n1-n2;
        case '*':
            return n1*n2;
        case '/':
            return n2/n1;
        case '^':
            return Math.pow(n2, n1);
    }
    return 0;
}

let evaluation = (expression) => {

    // Remove any whitespaces.
    expression = expression.replace(/\s/g, '');
    if(expression.length > 0 && expression[0] !== '(') {
        expression = '(' + expression + ')';
    }

    // Check if the given expression is valid.
    if(!isBalanced(expression)) {
        console.log('Expression is Wrong!');
        return null;
    }

    let expArray = postfixConvert(expression),
        stack = [];
    for(let i = 0; i < expArray.length; i++) {
        let current = expArray[i];

        // check if variable is operator or oprand
        if(isNaN(current)) {
            let num1 = stack.pop();
            let num2 = stack.pop();
            stack.push(calculate(num1, num2, current));
        } else {
            stack.push(current);
        }
    }

    return stack.pop();
}

console.log(evaluation('( (37 + 4) + 6)'));
console.log(evaluation('3+4+5+6'));
console.log(evaluation('(12 + (20 * 4 + 5) * 12^2 / 2)'));