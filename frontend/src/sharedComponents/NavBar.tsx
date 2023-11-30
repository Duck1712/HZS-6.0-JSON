import { useNavigate } from 'react-router-dom';
import styled from 'styled-components';

export const NavBar = () =>
{
    const navigate = useNavigate();
    return(
        <NavContainer>
            <Title onClick={()=>{
                navigate("/home")
            }}>
                BlogSport
            </Title>
            <Page>Registruj se</Page>
            <Page onClick={()=>{
                navigate("/login")
            }}>Prijavi se</Page>
        </NavContainer>
    )
}

const NavContainer = styled.div`
    display:flex;
    flex-direction:row;

    border-bottom: 2px solid gray;

`

const Title = styled.h2`
    position:relative;
    width:13%;
    padding:20px;
    cursor:pointer;
`

const Page = styled.h2`
    position:relative;
    right:-800px;
    width:13%;
    padding:20px;
    cursor:pointer;
`