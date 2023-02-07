function reverseMe() {
    //window.alert("Hi there it works");
    
    var lbl = document.getElementById("inputOne").value;

    const   reversedInput = lbl.split('').reverse().join(''); // crazy stuff !!!!



    document.getElementById("resultOne").innerHTML = "=>" +  reversedInput ;  
}


// excercise 2 

function isPalindrome(){

    var input = document.getElementById("inputTwo").value;


    const reversedInput = input.split('').reverse().join('');

    let result = false;

    if (input === reversedInput) {
        result = true ;
    } else {
        result = false ;
    }



    document.getElementById("resultTwo").innerHTML = result 

}

//excercise 3 

function multiply(a,b){

    alert(a*b);
    alert("The function works properly !")
    //return 

}