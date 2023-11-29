import styled from "styled-components"

export const Leaderboard = () =>
{
    
    return(
        <LbContainer>
            <Contestant>
                <h1>#1</h1>{/*"#{index+1}"*/}
                <ContestantText>TestContestant</ContestantText>
            </Contestant>                       
        </LbContainer>
    )
}

export const LbContainer = styled.div`
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

export const Contestant = styled.div`
    display:flex;
    border: 2px solid gray;
    border-radius: 15px;
    width:90%;
    height:20%;
    flex-direction:column;
`

export const ContestantText = styled.div`
    position:relative;
    left:20%;
    bottom:60%;

`