import styled from "styled-components"
import { Posts } from "../components/Posts"
import { Leaderboard } from "../components/Leaderboard"

export const Home = () => 
{
    return(
        <PageContainer>
            <Posts />
            <Leaderboard />
        </PageContainer>
    )
}

export const PageContainer = styled.div`
    background-color:#D7FFFB;
    width:100%;
    padding:20px;
    display:flex;
    flex-direction:column;
    align-items:flex-start;
`
export const PostContainer = styled.div`
    overflow:auto;
    height:450px;
    border: 2px solid gray;
    border-radius: 15px;
    width:60%;
    padding:30px;
    background-color:white;
    align-self:stretch;
`

export const Break = styled.div`
    flex-basis:100%;
    height:10px;

`