function isUnique(s){

    let set = new Set();

    for(let c of s){
        if(set.has(c)){
            return false;
        }else{
            set.add(c);
        }
    }

    return true;
}