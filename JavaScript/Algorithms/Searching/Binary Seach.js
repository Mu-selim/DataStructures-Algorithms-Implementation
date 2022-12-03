const binarySearch = (array, value) => {
    for(let i = 0; i < array.length; i++) {
        if(array[i] == value)
            return i;
    }
    return -1;
}

let array = [-1, 7, 7, 5, 12, 20, -3, -1, 11];
array.sort((a, b)=> a-b);
let position;
position = binarySearch(array, 12);
position != -1? console.log(`item found at index: ${position}`): console.log('item not found');

position = binarySearch(array, 100);
position != -1? console.log(`item found at index: ${position}`): console.log('item not found');