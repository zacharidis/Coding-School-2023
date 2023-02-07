function reverseMe() {
    //window.alert("Hi there it works");
    
    var lbl = document.getElementById("inputOne").value;

    const   reversedInput = lbl.split('').reverse().join(''); // crazy stuff !!!!



    document.getElementById("resultOne").innerHTML = "=>" +  reversedInput ;  
}