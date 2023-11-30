import styled from "styled-components"
import { Post } from "../components/Post"
import { PageContainer } from "./Home"

export const Stranica = () => {
    return(
        <PageContainer>
            <PostContainer>
               <h1>Informacije:</h1>
               <Break />
               <Post />
            </PostContainer>
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

const Username = styled.div'
{
    overflow:auto;
    height:450px;
    border: 2px solid gray;
    border-radius: 15px;
    width:40%;
    padding:20px;
    background-color:white;
    align-self:stretch;
    background-color: lightskyblue;
    border-radius: 50px;
    position: relative;
    top: 40px;
    left: 145px;
}

const Ime = styled.div'
{
    overflow:auto;
    height:450px;
    border: 2px solid gray;
    border-radius: 15px;
    width:40%;
    padding:20px;
    background-color:white;
    align-self:stretch;
    background-color: lightskyblue;
    border-radius: 50px;
    position: relative;
    top: 90px;
    left: 145px;
}

const Prezime = styled.div'
{
    overflow:auto;
    height:450px;
    border: 2px solid gray;
    border-radius: 15px;
    width:40%;
    padding:20px;
    background-color:white;
    align-self:stretch;
    background-color: lightskyblue;
    border-radius: 50px;
    position: relative;
    top: 140px;
    left: 145px;
}

const Email = styled.div'
{
    overflow:auto;
    height:450px;
    border: 2px solid gray;
    border-radius: 15px;
    width:40%;
    padding:20px;
    background-color:white;
    align-self:stretch;
    background-color: lightskyblue;
    border-radius: 50px;
    position: relative;
    top: 190px;
    left: 145px;
}

const Sifra = styled.div'
{
    overflow:auto;
    height:450px;
    border: 2px solid gray;
    border-radius: 15px;
    width:40%;
    padding:20px;
    background-color:white;
    align-self:stretch;
    background-color: lightskyblue;
    border-radius: 50px;
    position: relative;
    top: 240px;
    left: 145px;
}
