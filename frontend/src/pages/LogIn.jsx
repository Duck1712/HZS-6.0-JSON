import { styled } from "styled-components"
import { PageContainer } from "./Home";
import { useEffect, useState } from "react";



export const LogIn = () => {
    const [value, setValue] = useState('');
    const handleChange = (event) => {
        setValue(event.target.value); 
    }   

    const [pass,setPass] = useState('');
    const handlePassword = (event) =>
    {
        setPass(event.target.value);
    }   
    const username = value;
    const[users,setUsers]=useState([])
    const[password,setPassword] = useState('')
    const[id,setId] = useState('')
    useEffect(()=>{
        {async function  func()
        {
            fetch("http://localhost:5287/User",{
                method:"GET",
                headers:{
                            'Content-Type': 'application/json'
                        }
            }).then(data=>data.json()).then(data=>{setUsers(data)})
            users.forEach(user => {
                if(username==user.username)
                {
                    setPassword(user.password);
                    setId(user.id)
                }
            });
        } func()
        if(password == pass)
        {
            setId('/'+id)
        }
    }},[])
    if(id.startsWith('/'))
    {
        document.querySelector("#form").setAttribute("action",id)
    }
    return(
        <PageContainer>
            <Form id='form' method="get">
                <Label>
                    Unesite Username:
                    <Input id='user' onChange={handleChange}/>
                </Label>
                <Label>
                    Unesite Šifru:
                    <Input id='pass' onChange={handlePassword}/>
                </Label>
                <SubmitButton id="btn" type="submit">
                    Uloguj se
                </SubmitButton>
            </Form>
        </PageContainer>
    );
}


const Form = styled.form`
    display:flex;
    align-self:center;
    padding:20px;
    width:15%;
    justify-content:center;
    flex-direction:column;
    background-color: white;
    border: 2px solid rgb(185, 185, 255);
    border-radius: 5px;
    height:300px;
`

const Input = styled.input`

    border:2px solid lightskyblue;
    border-radius: 5px;
    font-size:16px;
    height: 25px;
    width: 150px;
`

const Label = styled.label`
    position:relative;
    top:-25%;
    padding:10px;
`

const SubmitButton = styled.button`
    border:2px solid green;
    border-radius:15px;
    background-color:white;
`
