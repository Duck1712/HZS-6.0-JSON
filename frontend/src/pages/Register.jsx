import { styled } from "styled-components"
import { PageContainer } from "./Home"
import { Form, Input, SubmitButton } from "./LogIn"

export const Register = () => {
    return(
        <Form>
            <label>Korisničko ime:</label>
            <Input type="text"></Input>
            <label>Šifra:</label>
            <Input type="text"></Input>
            <label>Ime:</label>
            <Input type="text"></Input>
            <label>Prezime:</label>
            <Input type="text"></Input>
            <label>Email:</label>
            <Input type="text"></Input>
            <SubmitButton>Registruj se</SubmitButton>
        </Form>
    )
}