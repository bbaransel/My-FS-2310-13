import React, { useContext, useEffect, useState } from 'react'
import { Button, Container, Form, InputGroup } from 'react-bootstrap'
import { AppContext } from '../Contexts/AppContext'

const SearchForm = () => {
    const context = useContext(AppContext)
    const [keyword, setKeyword] = useState("")
    // const clearButton = ()=>{
    //     if(keyword==""){
    //         setIsClearButtonShow(false)
    //     }else{
    //         setIsClearButtonShow(true)
    //     }
    // }
    const handleSubmit = (e) => {
        e.preventDefault();
        context.searchUsers(keyword)
    }
    const handleClearAllClick = () => {
        context.setUsers([]);
        setKeyword("");
        context.setIsClearButtonShow(false);
    }
    // bu hocanın yaptığı, benim yaptığım SearchPage.js içinde.
    useEffect(() => {
        handleClearAllClick();
    }, [])
    return (
        <>
            <Container className='py-3'>
                <Form onSubmit={handleSubmit}>
                    <InputGroup >
                        <Form.Control value={keyword} onChange={(e) => setKeyword(e.target.value)} placeholder='Enter search username'></Form.Control>
                        <Button type='submit' variant='success'>Search</Button>
                    </InputGroup>
                    {context.isClearButtonShow &&
                        <div className='d-grid mt-2'>
                            <Button variant='danger' onClick={() => handleClearAllClick()}>
                                {/*  { context.setUsers([]); setKeyword("") } */}
                                Clear All
                            </Button>
                        </div>
                    }
                </Form>
            </Container >
        </>
    )
}

export default SearchForm