export async function getAllTicker() {

    try{        
        const response = await fetch('https://localhost:44399/api/Ticker/GetAll');
        return await response.json();
    }catch(error) {
        return [];
    }
    
}

