export async function getLastPrices(sourceId,tickerId) {

    try{        
        const response = await fetch('https://localhost:44399/api/Price/LatestPriceList?sourceId='+sourceId +'&tickerId='+tickerId);
        return await response.json();
    }catch(error) {
        return [];
    }
    
}

export async function createRandomPrices(data) {
    const response = await fetch(`https://localhost:44399/api/Price/AddRandomPriceList`, {
        method: 'POST',
        headers: {'Content-Type': 'application/json'},
        body: JSON.stringify({user: data})
      })
    return await response.json();
}