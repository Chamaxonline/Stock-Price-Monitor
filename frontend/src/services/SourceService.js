export async function getAllSource() {

    try{        
        const response = await fetch('https://localhost:44399/api/source/GetAll');
        return await response.json();
    }catch(error) {
        return [];
    }
    
}