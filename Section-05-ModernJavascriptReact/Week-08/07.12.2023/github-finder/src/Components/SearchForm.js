import React from 'react'
import { Button, Container, Form, InputGroup } from 'react-bootstrap'

const SearchForm = () => {
    const handleSubmit = (e) => { 
        e.preventDefault();
        
     }
    return (
        <>
            <Container className='py-3'>
                <Form>
                    <InputGroup onSubmit={handleSubmit}>
                        <Form.Control placeholder='Enter search username'></Form.Control>
                        <Button type='submit' variant='success'>Search</Button>
                    </InputGroup>
                </Form>
            </Container>
        </>
    )
}

export default SearchForm