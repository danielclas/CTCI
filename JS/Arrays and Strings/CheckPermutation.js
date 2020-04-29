function checkPermutation(s, t){

    let S = {};
    let T = {};
    let keyS = [];
    let keyT = [];

    for(let c of s){
        if(S[c]) S[c]++;
        else{
            S[c]=1;
            keyS.push(c);
        }
    }

    for(let c of t){
        if(T[c]) T[c]++;
        else{
            T[c]=1;
            keyT.push(c);
        }
    }

    if(keyS.length != keyT.length) return false;
    else{
        for(let k of keyT)
            if(!T[k] || T[k]!=S[k]) return false;        
    }

    return true;

}