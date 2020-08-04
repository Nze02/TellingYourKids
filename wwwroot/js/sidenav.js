
    let openbtn = document.getElementById('open')
    let sidebar = document.getElementById('sidebar')
    let closebtn =document.getElementById('close')
    closebtn.style.display="none"
    openbtn.addEventListener('click', ((e)=>{
        e.preventDefault()
        setTimeout(()=>{
            
        sidebar.style.display="block"
        openbtn.style.display="none"
        closebtn.style.display="block";
        }, 500)
      
        closebtn.addEventListener('click', ((e)=>{
        setTimeout(()=>{
           
            e.preventDefault()
        sidebar.style.display="none"
        openbtn.style.display="block"
        closebtn.style.display="none";
       
}, 500)
}))
      
    }))