function checkPermutation(s, t){

    let S = {};
    let T = {};

    for(let c of s){
        if(S[c]){
            S[c]++;
        }else{
            S[c]=1;
        }
    }

    for(let c of t){
        if(T[c]){
            T[c]++;
        }else{
            T[c]=1;
        }
    }

    if(Object.keys(S).length != Object.keys(T).length){
        return false;
    }else{
        let keys = Object.keys(S);

        for(let k of keys)
            if(!T[k] || T[k]!=S[k]) return false;        
    }

    return true;

}