import { styled } from "styled-components"
import { PageContainer } from "./Home"

export const LogIn = () => {
    return(
        <PageContainer>
               <h1>Prijavite se:</h1>
               <Break />
               <Post />
        <PageContainer>
    );
}

const Form = styled.form'
{
    background-color: white;
    border: 2px solid rgb(185, 185, 255);
    border-radius: 5px;
    height: 450px;
    width: 550px;
}

const Input = styled.Input'
{
    border:2px solid rgb(185, 185, 255);
    background-color: lightskyblue;
    border-radius: 50px;
}

const MailInput = styled.MailInput'
{
    position: relative;
    height: 50px;
    widht: 200px;
    top: 100px;
    left: 75px;
}

const PassInput = styled.PassInput'
{
    position: relative;
    height: 50px;
    widht: 200px;
    top: 275px;
    right: 100px;
}

const SubmitButton = styled.SubmitButton'
{
    position: relative;
    height: 40px;
    widht: 300px;
    top: 190px;
}
