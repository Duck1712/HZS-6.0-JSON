import styled from "styled-components"
import { Break, PostContainer } from "../pages/Home"
import { useEffect, useState } from "react";


export const Posts = () =>
{

    const getPosts = async () =>
    {   
        
        var posts;
        const response = await fetch("http://localhost:5287/Post",{
            method:"GET",
            headers:{
                        'Content-Type': 'application/json'
                    }
        })
        .then(data=>data.json()).then(data=>{posts=data});
        return posts;
    }
    var posts = getPosts();

    const GetLength = () => 
    {
        const [len, setLen] = useState(0); 

        useEffect(() => { async function func() {await posts.then((response) => {
            setLen(response.length)
        })} func()});
        return len;
    }

    const Component = () => 
    {
        const [titles, setTitles] = useState(new Array(length)); 
        const [contents, setContents] = useState(new Array(length));
        // Send a request and on success, set the state to the response's body, and on fall set the state to the error message
        useEffect(() => { async function func() {posts.then((response) => {
            var tempTitle = [];
            var tempContent = [];
            if(length>0){
                tempTitle = new Array(length)
                tempContent = new Array(length)
                for(let i = 0; i< length; i++)
                {
                    tempTitle[i] = response[i].title
                    tempContent[i] = response[i].content
                }
            }
            setTitles(tempTitle);
            setContents(tempContent);
        })} func()});
        return [titles, contents];
    }

    var post;
    var length = GetLength();
    const [titles,contents] = Component();
    if(length>0)
    {
        var arr = new Array(length);
        for(let i =0; i<length;i++)
        {
            post = (
                <Content>
                    <h2>{titles[i]}</h2>{/*"#{index+1}"*/}
                    <Break />
                    {contents[i]}
                </Content>)
            arr[i] = post;
        }
        return(
            <PostContainer>      
                {arr}       
            </PostContainer>
        )
    }


    return(
        <PostContainer>
                
            <Content>
                <h2>Ja sam primer posta!</h2>
                <Break />
                Vidite me jer trenutno ne postoji nijedan drugi.
            </Content>
        </PostContainer>
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