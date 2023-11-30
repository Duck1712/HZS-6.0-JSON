import { styled } from "styled-components"
import { PageContainer } from "./Home"

export const Register = () => {
    return(
        <PageContainer>
               <h1>Prijavite se:</h1>
               <Break />
               <Post />
        <PageContainer>
    )
}

const Form = styled.form'
{
    background-color: white;
    border: 2px solid rgb(185, 185, 255);
    border-radius: 5px;
    height: 600px;
    width: 550px;
}

const Input = styled.Input'
{
    border:2px solid rgb(185, 185, 255);
    background-color: lightskyblue;
    border-radius: 50px;
}

const ImeInput = styled.ImeInput'
{
    position: relative;
    height: 50px;
    widht: 200px;
    top: 80px;
    left: 210px;
}

const PrezimeInput = styled.PrezimeInput'
{
    position: relative;
    height: 50px;
    widht: 200px;
    top: 180px;
    left: 35px;
}

const Korisnicko_ime = styled.Korisnicko_ime'
{
    position: relative;
    height: 50px;
    widht: 200px;
    top: 275px;
    right: 140px;
}

const MejlInput = styled.MejlInput'
{
    position: relative;
    height: 50px;
    widht: 200px;
    top: 315px;
    left: 33px;
}

const SifraInput = styled.SifraInput'
{
    position: relative;
    height: 50px;
    widht: 200px;
    top: 410px;
    left: 207px;
}