let msg = document.getElementById('msg')
let edit = document.querySelectorAll('.edit')
//text edit function
for (let i = 0; i < edit.length; i++) {
    window.addEventListener('load', (() => {
        console.log(edit[i])
        edit[i].addEventListener('click', ((e) => {
            e.target.style.background = "#e5e5e5"

            let done = e.target.nextElementSibling
            done.style.background = "#fff"

            let textarea = e.target.parentElement.previousElementSibling.previousElementSibling
            textarea.readOnly = false
            textarea.focus()
            //    done editing function
            done.addEventListener('click', (() => {
                textarea.readOnly = true;
                e.target.style.background = "#fff"
                done.style.background = "#e5e5e5"

                setTimeout(() => {
                    msg.style.display = "block"
                }, 500)
                setTimeout(() => {
                    msg.style.display = "none"
                }, 3000)
            }))
        }))
    }))
}


// select all checkboxes function

let checks = document.querySelectorAll(".side-checkbox")
let selectAll = document.getElementById('selectall')
///id fetch work
let formId = document.querySelectorAll("form")


// console.log([formId].length)
console.log(formId.innerHTML)

function toggle(source) {
    for (let x = 0, y = checks.length; x < y; x++) {

        checks[x].checked = source.checked
        // console.log(source.checked)
    }
}



let checkboxes = document.querySelectorAll('.side-checkbox')
let checkArr=checkboxes.forEach(checkbox=>console.log(checkbox.parentElement.nextElementSibling.getAttribute("id")))
// console.log(checkArr)
//text edit function
for (let i = 0; i < edit.length; i++) {
    window.addEventListener('load', (() => {
        let arr=[]
       
        
         checkboxes[i].addEventListener('click', ((e) => {
     
            if(checkboxes[i].checked){
                (checkboxes[i].parentElement.nextElementSibling.getAttribute("id"))
                arr.push(checkboxes[i].parentElement.nextElementSibling.getAttribute("id"))
             arr+=arr
            console.log(arr)
            }
           
        
        }))
    
        let arr1=([checkboxes[i].parentElement.nextElementSibling.getAttribute("id")])
        console.log(arr1)
    }
        ))}







//move up function
let move = document.getElementById('move')
let count = 0
move.style.zIndex = 10000000
function moveup() {
    count -= 60
    move.style.transform = `translateY(${count}px)`
    console.log(count)
}


function movedown(){
    count+=60
    move.style.transform = `translateY(${count}px)`
}