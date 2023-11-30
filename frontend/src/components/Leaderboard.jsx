import styled from "styled-components"
import {useState,useEffect} from 'react';

export const Leaderboard = () =>
{
    const getUsers = async () =>
    {   
        
        var users;
        const response = await fetch("http://localhost:5287/User",{
            method:"GET",
            headers:{
                        'Content-Type': 'application/json'
                    }
        })
        .then(data=>data.json()).then(data=>{users=data});
        return users;
    }
    var users = getUsers();



    const GetLength = () => 
    {
        const [len, setLen] = useState(0); // Create a state with an empty string as initial value
        
        // Send a request and on success, set the state to the response's body, and on fall set the state to the error message
        useEffect(() => { async function func() {await users.then((response) => {
            setLen(response.length)
        })} func()});
        return len;
    }

    const Component = () => 
    {
        const [usernames, setUsernames] = useState(new Array(length)); 
        
        // Send a request and on success, set the state to the response's body, and on fall set the state to the error message
        useEffect(() => { async function func() {users.then((response) => {
            var temp = [];
            if(length>0){
                temp = new Array(length)
                for(let i = 0; i< length; i++)
                {
                    temp[i] = response[i].username
                }
            }
            setUsernames(temp);
        })} func()});
        return usernames;
    }

    var contestant;
    var length = GetLength();
    const usernames = Component();
    if(length>0)
    {
        var arr = new Array(length);
        for(let i =0; i<length;i++)
        {
            contestant = (
                <Contestant>
                    <h1>#{i+1}</h1>{/*"#{index+1}"*/}
                    <ContestantText>{usernames[i]}</ContestantText>
                </Contestant>)
            arr[i] = contestant;
        }
        return(
            <LbContainer>      
                {arr}       
            </LbContainer>
        )
    }
    return(
        <LbContainer>
            <h1>Trenutno ne postoje korisnici.</h1>
        </LbContainer>
    )
    
}


export const LbContainer = styled.div`
    overflow:auto;
    display:flex;
    flex-direction:column;
    align-self:flex-end;
    border: 2px solid gray;
    border-radius: 15px;
    width:25%;
    height:450px;
    padding:30px;
    background-color:white;
    position:relative;
    left:-70px;
    bottom:513px;
    align-items:center;
`

export const Contestant = styled.div`
    display:flex;
    border: 2px solid gray;
    border-radius: 15px;
    width:90%;
    height:20%;
    flex-direction:column;
    padding:10px;
`

export const ContestantText = styled.div`
    position:relative;
    left:20%;
    bottom:60%;

`