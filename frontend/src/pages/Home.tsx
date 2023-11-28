import styled from "styled-components"
import { TextContainer } from "../sharedComponents/TextContainer"

export const Home = () => 
{
    return(
        <PageContainer>
            <TextContainer>
                <h1>Test!</h1>
            </TextContainer>
        </PageContainer>
    )
}

export const PageContainer = styled.div`
    background-color:#D7FFFB;
    width:100%;
    height:600px;
    padding:20px;
`