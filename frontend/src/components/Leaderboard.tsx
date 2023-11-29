import styled from "styled-components"

export const Leaderboard = () =>
{
    
    return(
        <LbContainer>
            <Contestant>
                <h1>#1</h1> 
                <b>TestContestant</b>
            </Contestant>                       
        </LbContainer>
    )
}

const LbContainer = styled.div`
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

const Contestant = styled.div`
    display:flex;
    border: 2px solid gray;
    border-radius: 15px;
    width:90%;
    height:20%;
    flex-direction:column;
`