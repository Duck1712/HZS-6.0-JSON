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
    const Component = (i) => 
    {
        const [username, setUsername] = useState(""); // Create a state with an empty string as initial value
        
        // Send a request and on success, set the state to the response's body, and on fall set the state to the error message
        useEffect(() => { async function func() {users.then((response) => {
            setUsername(response[i].username)
        })} func()});
        return username;
    }
    var b;
    var arr = []
    for(let i =0; i<3;i++)
    {
        const username = Component(i)
        console.log(username);
        b = (
            <Contestant>
                <h1>#{i+1}</h1>{/*"#{index+1}"*/}
                <ContestantText>{username}</ContestantText>
            </Contestant>)
        arr[i] = b
    }
    return(
        <LbContainer>      
            {arr}       
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