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
                Placeholder Title
            </Title>
        </NavContainer>
    )
}

const NavContainer = styled.div`
    border-bottom: 2px solid gray;

`

const Title = styled.h2`
    position:relative;
    width:13%;
    padding:20px;
    cursor:pointer;
`