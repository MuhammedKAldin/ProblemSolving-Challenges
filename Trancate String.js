trancateString = (element,limit) => {
    // Will get you closest index to the char u want 
    const index = element.indexOf(" ",limit);
    element = element.substr(0, index);
    console.log(element);
}
trancateString("brown fox jumps over the lazy dog",0); // Prints "brown" full word instead of "b"
