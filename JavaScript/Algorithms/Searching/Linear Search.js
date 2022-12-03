const linearSearch = (array, value) => {
    for(let i = 0; i < array.length; i++) {
        if(array[i] == value)
            return i;
    }
    return -1;
}

let array = [-1, 7, 7, 5, 12, 20, -3, -1, 11];
let position;
position = linearSearch(array, 12);
position != -1? console.log(`item found at index: ${position}`): console.log('item not found');

position = linearSearch(array, 100);
position != -1? console.log(`item found at index: ${position}`): console.log('item not found');