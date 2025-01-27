function Converter() {
    const table = document.getElementById("numbertablebody");
    const form = document.getElementById("converterform"); 
    const formData = new FormData(form); 
                
    const fromDegree = form.querySelector('select[name="fromDegree"]').value;
    const toDegree = form.querySelector('select[name="toDegree"]').value;
                
    fetch("http://localhost:5286/converter", {
        method: "POST",
        body: formData, // Send form data directly
    })
    .then((response) => {
        if (!response.ok) {
            throw new Error("Failed to fetch data");
        }
        return response.json();
    })
    .then((data) => {
        console.log("Response data:", data);
        table.innerHTML = `${formData.get("number")} ${fromDegree.charAt(0).toUpperCase() + fromDegree.slice(1)} is ${data} ${toDegree.charAt(0).toUpperCase() + toDegree.slice(1)}`;
    })
    .catch((error) => {
        console.error("Error:", error);
    });
}