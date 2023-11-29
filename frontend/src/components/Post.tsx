import styled from "styled-components"
import { Break } from "../pages/Home"


export const Post = (data:any) =>
{
    return(
        <Content>
            <h2>title</h2>
            <Break />
            Content
        </Content>
    )
}

const Content = styled.div`
    display:flex;
    flex-wrap:wrap;
    border: 2px solid gray;
    border-radius: 15px;
    width:95%;
    padding:10px;
    justify-content:left;
    background-color:white;`