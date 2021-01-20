function handleForm(event) { event.preventDefault(); } 

var submit = document.getElementById("calcGrade");

submit.addEventListener("click", function () {
    iAssign = document.getElementById("Assignments").value
    igp = document.getElementById("Gp").value
    iQuiz = document.getElementById("Quiz").value
    iExam = document.getElementById("Exam").value
    iIntex = document.getElementById("INTEX").value

    //calc total % grade
    itotal = (iAssign * .5) + (igp * .1) + (iQuiz * .1) + (iExam * .2) + (iIntex * .1)
    
    //calc letter grade 
    if (itotal >= 94)
    {
        sGrade = "A"
    }
    else if (itotal >= 90) {
        sGrade = "A-"
    }
    else if (itotal >= 87) {
        sGrade = "B+"
    }
    else if (itotal >= 84) {
        sGrade = "B"
    }
    else if (itotal >= 80) {
        sGrade = "B-"
    }
    else if (itotal >= 74) {
        sGrade = "C"
    }
    else if (itotal >= 70) {
        sGrade = "C-"
    }
    else if (itotal >= 67) {
        sGrade = "D+"
    }
    else if (itotal >= 64) {
        sGrade = "D"
    }
    else if (itotal >= 60) {
        sGrade = "D-"
    }
    else{
        sGrade = "E"
    }

    //output
    alert(itotal + " " + sGrade);
    document.getElementById("output").innerHTML = "Your final grade is " + itotal + "% which is a " + sGrade;
});

